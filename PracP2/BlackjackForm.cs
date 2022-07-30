using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace PracP2
{
  public partial class BlackjackForm : Form
  {

    //#############################################################################################
    //# Instance variables
    private Card playerCard1;
    private Card playerCardFinal;

    private Card dealerCard1;
    private Card dealerCard2;

    private int currentAmount = 0;
    private int playerBet = 0;

    private int winCount = 0;
    private int lostCount = 0;

    private bool firstCardDeal = false;

    //Creates a new deck
    Deck deck = new Deck();

    //Creates a hand object for the player and dealer
    Hand playerHand = new Hand();
    Hand dealerHand = new Hand();

    //#############################################################################################
    //# Constants
    /// <summary>
    /// Total number of cards
    /// </summary>
    private const int NUM_CARDS = 52;
    /// <summary>
    /// Maximum points allowed before going bust
    /// </summary>
    private const int BLACKJACK = 21;
    /// <summary>
    /// Initial amount of money available to the player (to implement betting).
    /// </summary>
    private const int START_MONEY = 100;

    //#############################################################################################
    //# Constructor
    public BlackjackForm()
    {
      InitializeComponent();
      // Prevent the user from resising the form
      MinimumSize = MaximumSize = Size;
      //Sets player's start money to 100
      currentAmount = START_MONEY;
      textBoxMoneyLeft_.Text = START_MONEY.ToString();
      //Sets win and loss textboxes to 0 each
      textBoxWins.Text = winCount.ToString();
      textBoxLosses.Text = lostCount.ToString();
    }


    //#############################################################################################
    //# Event Handlers
    private void buttonDealFirstCard_Click(object sender, EventArgs e)
    {
      if (firstCardDeal == true)
      {
                MessageBox.Show("You have already been dealt the first card!");
      }
      else
      {
                //Gives the first card to the player and two cards to the dealer
                playerCard1 = deck.DealCard();
                playerHand.handList.Add(playerCard1);

                dealerCard1 = deck.DealCard();
                dealerCard2 = deck.DealCard();
                dealerHand.handList.Add(dealerCard1);
                dealerHand.handList.Add(dealerCard2);

                //Display the first card to player and dealer
                listBoxPlayerHand.Items.Add(playerCard1);
                listBoxDealerHand.Items.Add(dealerCard1);

                textBoxPlayerTotal_.Text = playerHand.Total.ToString();
                //Displays the points of the dealer's first card. The other one is hidden.
                textBoxDealerTotal_.Text = dealerCard1.Points.ToString();

                if (dealerHand.Total <= 14)
                {
                    Card dealerExtraCard = deck.DealCard();
                    dealerHand.handList.Add(dealerExtraCard);
                }
                firstCardDeal = true;
      }
      
    }

    private void buttonDeal_Click(object sender, EventArgs e)
    {
            if (firstCardDeal == false)
            {
                MessageBox.Show("You have not been dealt your first card yet!");
            }
            else
            {
                try
                {
                    //Gets player's bet
                    playerBet = int.Parse(textBoxBet_.Text);

                    Card playerExtraCard = deck.DealCard();

                    playerHand.handList.Add(playerExtraCard);

                    listBoxPlayerHand.Items.Add(playerExtraCard);
                    textBoxPlayerTotal_.Text = playerHand.Total.ToString();

                    if (playerHand.handList.Count >= 5 & playerHand.Total <= 21)
                    {
                        //Player wins the bet amount
                        currentAmount += playerBet;
                        MessageBox.Show("You win!");
                        //Increases win count by 1;
                        winCount += 1;
                        ResetRound();
                    }

                    if (playerHand.Total > BLACKJACK)
                    {
                        currentAmount = LoseGame(playerBet);
                        ResetRound();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    }

    private void buttonDealSecondCard_Click(object sender, EventArgs e)
    {
            if (firstCardDeal == false)
            {
                  MessageBox.Show("You have not been dealt your first card yet!");
            }
            else
            {
                try
                {
                    //Gets player's bet
                    playerBet = int.Parse(textBoxBet_.Text);
                    //Deals the player's final card
                    playerCardFinal = deck.DealCard();
                    playerHand.handList.Add(playerCardFinal);
                    //Checks if player money is lower than current amount
                    if (playerBet > currentAmount)
                    {
                        MessageBox.Show("Please enter a valid bet.");
                        textBoxBet_.Clear();
                    }
                    else
                    {
                        listBoxPlayerHand.Items.Clear();
                        listBoxDealerHand.Items.Clear();

                        foreach (Card playerCard in playerHand.handList)
                        {
                            listBoxPlayerHand.Items.Add(playerCard);
                        }

                        foreach (Card dealerCard in dealerHand.handList)
                        {
                            listBoxDealerHand.Items.Add(dealerCard);
                        }

                        textBoxPlayerTotal_.Text = playerHand.Total.ToString();
                        textBoxDealerTotal_.Text = dealerHand.Total.ToString();

                        if (playerHand.Total > BLACKJACK)
                        { // Player bust: loses even if dealer bust.
                            currentAmount = LoseGame(playerBet);
                        }
                        else if (dealerHand.Total > BLACKJACK || playerHand.Total > dealerHand.Total)
                        {
                            //Player wins the bet amount
                            currentAmount += playerBet;
                            MessageBox.Show("You win!");
                            //Increases win count by 1;
                            winCount += 1;
                        }
                        else if (playerHand.Total == dealerHand.Total)
                        {
                            MessageBox.Show("You tie!");
                        }
                        else
                        { // Player total less than dealer, and dealer did not bust.
                            currentAmount = LoseGame(playerBet);
                        }
                        ResetRound();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
    }

    private void buttonQuit_Click(object sender, EventArgs e)
    {
      this.Close();
    }


    //#############################################################################################
    //# Private Methods
    private int LoseGame(int lostAmount)
    {
      MessageBox.Show("You lose!");
      //Player loses the bet amount
      currentAmount -= playerBet;
      //Increases lost counts by 1;
      lostCount += 1;
      return currentAmount;
    }

    private void ResetRound()
    {
       listBoxPlayerHand.Items.Clear();
       listBoxDealerHand.Items.Clear();
       playerHand.Total = 0;
       dealerHand.Total = 0;
       playerHand.handList.Clear();
       dealerHand.handList.Clear();
       textBoxPlayerTotal_.Text = "";
       textBoxDealerTotal_.Text = "";
       textBoxBet_.Text = "";
       textBoxMoneyLeft_.Text = currentAmount.ToString();
       //Display wins and losses to the respective textboxes
       textBoxWins.Text = winCount.ToString();
       textBoxLosses.Text = lostCount.ToString();
       firstCardDeal = false;
       //Checks if the player has run out of money
       if (currentAmount <= 0)
       {
          MessageBox.Show("Oh no. You have run out of money and cannot play anymore. Bye.");
          this.Close();
       }
    }
  }
}
