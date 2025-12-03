using System.Net;
using Newtonsoft.Json;

namespace BitcoinCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    (currencySelector.SelectedItem.ToString() != "USD" &&
                    currencySelector.SelectedItem.ToString() != "EUR")
                    || currencySelector.SelectedItem == null
                    )
                {
                    MessageBox.Show("Error", "VALUUTA ON VALIMATA");
                }
                else if (currencySelector.SelectedItem.ToString() == "USD")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoinAmountKogus.Text) *
                    newRate.Data.BTCUSD.VALUE);
                    bitcoinResultLabel.Text = result.ToString();
                }
                else if (currencySelector.SelectedItem.ToString() == "EUR")
                {
                    BitcoinRates newRate = BitcoinRates();
                    float result = (float)(float.Parse(bitcoinAmountKogus.Text) *
                    newRate.Data.BTCEUR.VALUE);
                    bitcoinResultLabel.Text = result.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tekkis viga, vea detailid: {ex.Message}", $"{ex}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static BitcoinRates BitcoinRates()
        {
            string URL = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-EUR&apply_mapping=true&api_key=ce6820756af2ab349a91fcfcf5cdfea858d0f55d16819667a3153a35f7d42045";


            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates netbitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                netbitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return netbitcoin;


        }

        private void bitcoinAmountKogus_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArvutuseTulemus_Click(object sender, EventArgs e)
        {

        }

        private void currencySelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
