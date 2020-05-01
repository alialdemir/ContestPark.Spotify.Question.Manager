using SpotifyAPI.Web;
using System;
using System.Windows.Forms;

namespace ContestPark.Spotify.Question.Manager
{
    public partial class Form1 : Form
    {
        private const short musicCategoryId = 4;

        private SpotifyWebAPI spotifyWebAPI = new SpotifyWebAPI
        {
            AccessToken = "BQANuNqIOB9kvWP-srfCoND0tfu0JDrva6Z8GBoy5JUlFsL-WTq9Lr6YbF7JBASZmWrIdto4DNLrfbh2syH7rMDIzGWfV_nVcd0CjAe6aoFqry5U__HrjeigHmnEz5FEpRr-bmN-KAjhfwtXZOWtpsdJSvXe0X76MR_eKIn9q7SSzdYMYL0IiAxpw_AVD97DFJZg98iB3y511jne8LiceHiCKzj09rWmhhRPo4fcXkABBf78Abv5ylCquspFgVPpCj0V3-NnJ6tJIg",
            TokenType = "Bearer"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnToken_Click(object sender, EventArgs e)
        {
            using (frmSubCategory frm = new frmSubCategory())
            {
                frm.ShowDialog();
            }
            //FullPlaylist fullPlaylist = spotifyWebAPI.GetPlaylist("37i9dQZF1DXdnOj1VEuhgb");

            //SubCategory subCategory = new SubCategory
            //{
            //    CategoryId = musicCategoryId,
            //    PicturePath = fullPlaylist.Images.FirstOrDefault().Url,
            //    DisplayOrder = 0,
            //    DisplayPrice = "11",
            //    Price = 11,
            //    Visibility = true,
            //    SubCategoryLangs = new List<SubCategoryLang>
            //     {
            //         new SubCategoryLang
            //         {
            //               Decription = "1234",
            //               Language= Enums.Languages.English,
            //               SubCategoryName = "test"
            //         }
            //     }
            //};
            //pictureBox1.LoadAsync(thumbnailImage);
        }
    }
}