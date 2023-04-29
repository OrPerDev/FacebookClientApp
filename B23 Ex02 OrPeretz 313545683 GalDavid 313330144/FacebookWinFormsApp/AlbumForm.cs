using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class AlbumForm : Form
    {
        private readonly Album r_AlbumToDisplay = null;
        private readonly FacebookObjectCollection<Photo> r_AlbumPhotos = null;
        private Photo m_CurrentPhoto;
        private int m_CurrentPhotoIndex = 0;

        public AlbumForm(Album i_AlbumToDisplay)
        {
            if (i_AlbumToDisplay.Photos.Count == 0)
            {
                throw new Exception("The album has no pictures in it!");
            }
            this.r_AlbumToDisplay = i_AlbumToDisplay;
            this.r_AlbumPhotos = i_AlbumToDisplay.Photos;
            InitializeComponent();
            this.initAlbumForm();
        }

        private void initAlbumForm()
        {
            this.updateRotationOverPictures();
            this.updatePhotoData();
        }

        private void updatePhotoData()
        {
            this.Text = $"Presenting Album - {this.r_AlbumToDisplay.Name}";
            this.m_CurrentPhoto = this.r_AlbumPhotos[this.m_CurrentPhotoIndex];
            this.PictureLinkLabel.Links.Clear();
            this.PictureLinkLabel.Links.Add(0, this.m_CurrentPhoto.PictureNormalURL.Length, this.m_CurrentPhoto.Link);
            this.CurrentPictureBox.Image = this.m_CurrentPhoto.ImageNormal;
        }

        private void updateRotationOverPictures()
        {
            if (this.r_AlbumPhotos.Count == 1)
            {
                this.LeftArrowPictureBox.Image = null;
                this.LeftArrowPictureBox.Enabled = false;
                this.RightArrowPictureBox.Image = null;
                this.RightArrowPictureBox.Enabled = false;
            }
            else if (this.m_CurrentPhotoIndex == 0)
            {
                this.LeftArrowPictureBox.Image = null;
                this.LeftArrowPictureBox.Enabled = false;
                this.RightArrowPictureBox.Image = Properties.Resources.White_Right_Arrow;
                this.RightArrowPictureBox.Enabled = true;
            }
            else if (this.m_CurrentPhotoIndex == this.r_AlbumPhotos.Count - 1)
            {
                this.RightArrowPictureBox.Image = null;
                this.RightArrowPictureBox.Enabled = false;
                this.LeftArrowPictureBox.Image = Properties.Resources.White_Left_Arrow;
                this.LeftArrowPictureBox.Enabled = true;
            }
            else
            {
                this.LeftArrowPictureBox.Image = Properties.Resources.White_Left_Arrow;
                this.LeftArrowPictureBox.Enabled = true;
                this.RightArrowPictureBox.Image = Properties.Resources.White_Right_Arrow;
                this.RightArrowPictureBox.Enabled = true;
            }
        }

        private void RightArrowPictureBox_Click(object sender, EventArgs e)
        {
            this.m_CurrentPhotoIndex += 1;
            this.m_CurrentPhoto = this.r_AlbumPhotos[this.m_CurrentPhotoIndex];
            this.updatePhotoData();
            this.updateRotationOverPictures();
        }

        private void LeftArrowPictureBox_Click(object sender, EventArgs e)
        {
            this.m_CurrentPhotoIndex -= 1;
            this.m_CurrentPhoto = this.r_AlbumPhotos[this.m_CurrentPhotoIndex];
            this.updatePhotoData();
            this.updateRotationOverPictures();
        }

        private void PictureLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel currentLabel = sender as LinkLabel;
            try
            {
                System.Diagnostics.Process.Start(currentLabel.Links[0].LinkData.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open gallery of album due to - {ex.Message}", "Facebook DP App - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
