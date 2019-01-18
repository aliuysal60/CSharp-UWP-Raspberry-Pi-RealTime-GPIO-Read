using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Gpio;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RaspberryPiUniversalApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            InitGPIO();

        }
        private void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            // GPIO denetleyici yoksa hata uyarı göster
            if (gpio == null)
            {
                GpioStatus.Text = "Denetleyici Yok";
                GpioStatus.Foreground = redBrush;
                return;
            }

            GPIO04pin = gpio.OpenPin(GPIO04);
            GPIO05pin = gpio.OpenPin(GPIO05);
            GPIO06pin = gpio.OpenPin(GPIO06);
            GPIO12pin = gpio.OpenPin(GPIO12);
            GPIO13pin = gpio.OpenPin(GPIO13);
            GPIO16pin = gpio.OpenPin(GPIO16);
            GPIO17pin = gpio.OpenPin(GPIO17);
            GPIO18pin = gpio.OpenPin(GPIO18);
            GPIO19pin = gpio.OpenPin(GPIO19);
            GPIO20pin = gpio.OpenPin(GPIO20);
            GPIO21pin = gpio.OpenPin(GPIO21);
            GPIO22pin = gpio.OpenPin(GPIO22);
            GPIO23pin = gpio.OpenPin(GPIO23);
            GPIO24pin = gpio.OpenPin(GPIO24);
            GPIO25pin = gpio.OpenPin(GPIO25);
            GPIO26pin = gpio.OpenPin(GPIO26);
            GPIO27pin = gpio.OpenPin(GPIO27);




            // GPIO04 PULL CONTROL
            if (GPIO04pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO04pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO04pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO04pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO04pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO05 PULL CONTROL
            if (GPIO05pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO05pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO05pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO05pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO05pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";



            // GPIO06 PULL CONTROL
            if (GPIO06pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO06pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO06pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO06pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO06pin.ValueChanged += Pin_ValueChanged;

            //       GpioStatus.Text = "GPIO hatasız başlatıldı";




            // GPIO12 PULL CONTROL
            if (GPIO12pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO12pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO12pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO12pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO12pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO13 PULL CONTROL
            if (GPIO13pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO13pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO13pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO13pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO13pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";




            // GPIO16 PULL CONTROL
            if (GPIO16pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO16pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO16pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO16pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO16pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO17 PULL CONTROL
            if (GPIO17pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO17pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO17pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO17pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO17pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";




            // GPIO18 PULL CONTROL
            if (GPIO18pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO18pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO18pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO18pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO18pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO19 PULL CONTROL
            if (GPIO19pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO19pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO19pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO19pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO19pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO20 PULL CONTROL
            if (GPIO20pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO20pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO20pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO20pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO20pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO21 PULL CONTROL
            if (GPIO21pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO21pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO21pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO21pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO21pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO22 PULL CONTROL
            if (GPIO22pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO22pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO22pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO22pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO22pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO23 PULL CONTROL
            if (GPIO23pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO23pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO23pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO23pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO23pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO24 PULL CONTROL
            if (GPIO24pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO24pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO24pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO24pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO24pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO25 PULL CONTROL
            if (GPIO25pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO25pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO25pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO25pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO25pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO26 PULL CONTROL
            if (GPIO26pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO26pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO26pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO26pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO26pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";





            // GPIO27 PULL CONTROL
            if (GPIO27pin.IsDriveModeSupported(GpioPinDriveMode.InputPullUp))
                GPIO27pin.SetDriveMode(GpioPinDriveMode.InputPullUp);
            else
                GPIO27pin.SetDriveMode(GpioPinDriveMode.Input);

            // Butona basıldığında gürültüyü filitrelemek için zaman aşımı ayarla
            GPIO27pin.DebounceTimeout = TimeSpan.FromMilliseconds(50);

            // Register for the ValueChanged event so our buttonPin_ValueChanged 
            GPIO27pin.ValueChanged += Pin_ValueChanged;

            //  GpioStatus.Text = "GPIO hatasız başlatıldı";



        }



        private void Pin_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs e)
        {
            // need to invoke UI updates on the UI thread because this event
            // handler gets invoked on a separate thread.
            var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
                var PinName = GetPinName(sender.PinNumber);
                var PinTextName = GetPinTextName(sender.PinNumber);
                var PinIcon = MainGrid.FindName(PinName) as Ellipse;
                var PinText = MainGrid.FindName(PinTextName) as TextBlock;

                var test = Gpio04Status;

                if (e.Edge == GpioPinEdge.FallingEdge)
                {
                    PinIcon.Fill = redBrush;
                    PinText.Text = "Çekiliyor";
                }
                else
                {
                    PinIcon.Fill = grayBrush;
                    PinText.Text = "Boşta";
                }
            });
        }

        private string GetPinName(int pinNumber)
        {
            return $"OGPIO{pinNumber:D2}";
        }

        private string GetPinTextName(int pinNumber)
        {
            return $"Gpio{pinNumber:D2}Status";
        }

        private const int GPIO04 = 4;
        private const int GPIO05 = 5;
        private const int GPIO06 = 6;
        private const int GPIO12 = 12;
        private const int GPIO13 = 13;
        private const int GPIO16 = 16;
        private const int GPIO17 = 17;
        private const int GPIO18 = 18;
        private const int GPIO19 = 19;
        private const int GPIO20 = 20;
        private const int GPIO21 = 21;
        private const int GPIO22 = 22;
        private const int GPIO23 = 23;
        private const int GPIO24 = 24;
        private const int GPIO25 = 25;
        private const int GPIO26 = 26;
        private const int GPIO27 = 27;
        private GpioPin GPIO04pin;
        private GpioPin GPIO05pin;
        private GpioPin GPIO06pin;
        private GpioPin GPIO12pin;
        private GpioPin GPIO13pin;
        private GpioPin GPIO16pin;
        private GpioPin GPIO17pin;
        private GpioPin GPIO18pin;
        private GpioPin GPIO19pin;
        private GpioPin GPIO20pin;
        private GpioPin GPIO21pin;
        private GpioPin GPIO22pin;
        private GpioPin GPIO23pin;
        private GpioPin GPIO24pin;
        private GpioPin GPIO25pin;
        private GpioPin GPIO26pin;
        private GpioPin GPIO27pin;
        private GpioPinValue PinValue = GpioPinValue.High;

        //    private DispatcherTimer timer;
        private SolidColorBrush redBrush = new SolidColorBrush(Windows.UI.Colors.Red);
        private SolidColorBrush yellowBrush = new SolidColorBrush(Windows.UI.Colors.Yellow);
        private SolidColorBrush grayBrush = new SolidColorBrush(Windows.UI.Colors.LightGray);

        private void textBlock_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
