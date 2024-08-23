using PickRandomCards;
namespace PickRandomCardsMAUI
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            string enteredCardNumber = NumberOfCards.Text;
            if (!string.IsNullOrEmpty(enteredCardNumber)) {
                if (int.TryParse(enteredCardNumber, out int cardNumber))
                {
                    string[] cards = CardPicker.PickSomeCards(cardNumber);
                    string newHandData = "";
                    foreach (string card in cards) {
                        newHandData += card + Environment.NewLine;
                    }
                    CardsPickedLabel.Text = newHandData;
                    CardsPickedLabel.BackgroundColor = Colors.SlateGray;
                } else
                {
                    HeadingLabel.Text = "Please enter a valid card number";
                }
            } 
        }
    }

}
