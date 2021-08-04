using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace EmbeddedResourceTextSample
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout mainStack = new StackLayout(); // for Title label 
            StackLayout textStack = new StackLayout // for Text Body
            {
                Padding = new Thickness(5),
                Spacing = 10
            };

            // Get access to the text resource.
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            string resource = "EmbeddedResourceTextSample.Texts.TheBlackCat.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resource))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    bool gotTitle = false;
                    string line;

                    // Read in a line (which is actually a paragraph).
                    while (null != (line = reader.ReadLine()))
                    {
                        Debug.WriteLine("line: " + line);
                        Label label = new Label
                        {
                            Text = line,
                            // Black text for ebooks!
                            TextColor = Color.Black
                        };
                        if (!gotTitle)
                        {
                            // Add first label (the title) to mainStack.
                            label.HorizontalOptions = LayoutOptions.Center;
                            label.FontSize = Device.GetNamedSize(NamedSize.Medium, label);
                            label.FontAttributes = FontAttributes.Bold;
                            mainStack.Children.Add(label);
                            gotTitle = true;
                        }
                        else
                        {
                            // Add subsequent labels to textStack.
                            textStack.Children.Add(label);
                        }
                    }
                }
            }

            // Put the textStack in a ScrollView with FillAndExpand.
            ScrollView scrollView = new ScrollView
            {
                Content = textStack,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(5, 0),
            };

            // Add the ScrollView as a second child of mainStack.
            mainStack.Children.Add(scrollView);

            // Set page content to mainStack.
            Content = mainStack;

            // White backgorund for e book.
            BackgroundColor = Color.White;

            // Add some iOS padding for the page
            Padding = new Thickness(0, Device.RuntimePlatform == Device.iOS ? 60 : 0, 0, 0);
        }
    }
}

