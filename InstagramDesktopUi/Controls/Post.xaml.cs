using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InstagramDesktopUi.Controls
{
    /// <summary>
    /// Interaction logic for Post.xaml
    /// </summary>
    public partial class Post : UserControl
    {
        public static readonly DependencyProperty PostSourceProperty = DependencyProperty.Register("PostSource", typeof(ImageSource), typeof(Post));
        public static readonly DependencyProperty ProfileSourceProperty = DependencyProperty.Register("ProfileSource", typeof(ImageSource), typeof(Post));
        public static readonly DependencyProperty ProfileNameProperty = DependencyProperty.Register("ProfileName", typeof(string), typeof(Post));
        public static readonly DependencyProperty LikesProperty = DependencyProperty.Register("Likes", typeof(string), typeof(Post));
        public static readonly DependencyProperty CommentsProperty = DependencyProperty.Register("Comments", typeof(string), typeof(Post));

        public ImageSource PostSource
        {
            get { return (ImageSource)GetValue(PostSourceProperty); }
            set { SetValue(PostSourceProperty, value); }
        }

        public ImageSource ProfileSource
        {
            get { return (ImageSource)GetValue(ProfileSourceProperty); }
            set { SetValue(ProfileSourceProperty, value); }
        }

        public string ProfileName
        {
            get { return (string)GetValue(ProfileNameProperty); }
            set { SetValue(ProfileNameProperty, value); }
        }

        public string Likes
        {
            get { return (string)GetValue(LikesProperty); }
            set { SetValue(LikesProperty, value); }
        }

        public string Comments
        {
            get { return (string)GetValue(CommentsProperty); }
            set { SetValue(CommentsProperty, value); }
        }

        public Post()
        {
            InitializeComponent();
        }
    }
}
