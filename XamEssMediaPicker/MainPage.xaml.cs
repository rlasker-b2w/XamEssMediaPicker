using ByteSizeLib;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamEssMediaPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void PickPhotoButton_Clicked(object sender, System.EventArgs e)
        {
            FileResult mediaFile = await MediaPicker.PickPhotoAsync(new MediaPickerOptions()
            {
                Title = "Take Photo",
            });

            if (mediaFile != null)
            {
                PickPhotoSizeLabel.Text = $"{ ByteSize.FromBytes((await mediaFile.OpenReadAsync()).Length): MB}";
            }
        }

        async void TakePhotoButton_Clicked(object sender, System.EventArgs e)
        {
            FileResult mediaFile = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions()
            {
                Title = "Take Photo",
            });

            if (mediaFile != null)
            {
                TakePhotoSizeLabel.Text = $"{ ByteSize.FromBytes((await mediaFile.OpenReadAsync()).Length): MB}";
            }
        }
    }
}
