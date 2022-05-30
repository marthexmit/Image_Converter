﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace furi_imageProcessing
{
    public partial class Form1 : Form
    {
        private Bitmap img1;
      

        private Bitmap img2;
        

        private Bitmap imgR;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            // Abre a caixa de diálogo Open
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\MatLab"; // Define o diretorio padrâo de selcao de imagem
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif" + // Define as possiveis extensoes das imagens
                "|JPG image (*.jpg)|*.jpg" +
                "|BMP image (*.bmp)|*.bmp" +
                "|PNG image (*.png)|*.png" +
                "|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se o arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                bool bLoadImgOk = false;

                try
                {
                    img1 = new Bitmap(filePath);
                    bLoadImgOk = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error opening image A",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bLoadImgOk = false;
                }

                if (bLoadImgOk)
                {
                    // Adiciona 
                    pbA.Image = img1;
                   

                }
            }
        }//Fim do evento click btnA

        private void btnB_Click(object sender, EventArgs e)
        {
            // Abre a caixa de diálogo Open
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\MatLab"; //Define o diretorio padrâo de selcao de imagem
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif" + //Define as possiveis extensoes das imagens
                "|JPG image (*.jpg)|*.jpg" +
                "|BMP image (*.bmp)|*.bmp" +
                "|PNG image (*.png)|*.png" +
                "|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            //Se o arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                bool bLoadImgOk = false;

                try
                {
                    img2 = new Bitmap(filePath);
                    bLoadImgOk = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error opening image B",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bLoadImgOk = false;
                }

                if (bLoadImgOk)
                {
                    pbB.Image = img2;
                }
            }
        }//Fim do evento click btB

        private void pbA_Click(object sender, EventArgs e)
        {
            btnA_Click(sender, e);
        }

        private void pbB_Click(object sender, EventArgs e)
        {
            btnB_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = addImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error adding images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap addImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;
                    int R, G, B;
                    if (color1 != color2)
                    {
                        R = color1.R + color2.R;
                        G = color1.G + color2.G;
                        B = color1.B + color2.B;

                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        color = Color.FromArgb(R, G, B);
                    }
                    else color = color1;
                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        

        private void txtDivA_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntDivA_Click(object sender, EventArgs e)
        {
            string txt = txtDivA.Text;
            if (txt == "") txt = "1";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0 || num > 255)
            {
                MessageBox.Show("Please insert a value in range 1 - 255", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img1);
                img1 = divImage(img1, double.Parse(txt));
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error to divide images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap divImage(Bitmap image, double num)
        { 
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;
                    int R, G, B;

                    R = (int)(color.R / num);
                    G = (int)(color.G / num);
                    B = (int)(color.B / num);

                    colorOut = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, colorOut);
                }
            }
            return outputImage;
        }

        private Bitmap divImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    int R2 = color2.R, G2 = color2.G, B2 = color2.B;
                    Color color;
                    int R, G, B;

                    if (R2 == 0) R2 = 1;
                    if (G2 == 0) G2 = 1;
                    if (B2 == 0) B2 = 1;

                    R = (int)(color1.R / R2);
                    G = (int)(color1.G / G2);
                    B = (int)(color1.B / B2);

                    if (R < 0) R = 0;
                    else if (R > 255) R = 255;
                    if (G < 0) G = 0;
                    else if (G > 255) G = 255;
                    if (B < 0) B = 0;
                    else if (B > 255) B = 255;

                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private Bitmap resizeImage(Bitmap imgToResize)
        {
            Size size;
            Size sizeA = new Size(img1.Width, img1.Height);
            Size sizeB = new Size(img2.Width, img2.Height);
            if (sizeA.Width > sizeB.Width && sizeA.Height > sizeB.Height) size = sizeA;
            else size = sizeB;

            return new Bitmap(imgToResize, size);
        }

        private Bitmap collageVBitmap(Bitmap[] images)
        {
            images[0] = resizeImage(images[0]);
            images[1] = resizeImage(images[1]);

            var outputHeight = images.Sum(x => x.Height);
            var outputWidth = images[0].Width;

            var outputImage = new Bitmap(outputWidth, outputHeight);

            using (var g = Graphics.FromImage(outputImage))
            {
                //set background color
                g.Clear(System.Drawing.Color.Black);

                //go through each image and draw it on the output image
                int offset = 0;
                foreach (System.Drawing.Bitmap image in images)
                {
                    g.DrawImage(image,
                        new System.Drawing.Rectangle(0, offset, image.Width, image.Height)
                    );
                    offset += image.Height;
                }
            }
            return new Bitmap(outputImage);
        }
        byte Average(byte a, byte b)
        {
            return (byte)((a + b) / 2);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);
                imgR = subImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error subtracting images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap subImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;
                    int R, G, B;
                    if (color1 != color2)
                    {
                        R = color1.R - color2.R;
                        G = color1.G - color2.G;
                        B = color1.B - color2.B;

                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        color = Color.FromArgb(R, G, B);
                    }
                    else color = color1;
                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);
                imgR = avgImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error averaging images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap avgImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color Color1 = imgA.GetPixel(x, y);
                    Color Color2 = imgB.GetPixel(x, y);
                    Color color = Color.FromArgb(Average(Color1.R, Color2.R), Average(Color1.G, Color2.G), Average(Color1.B, Color2.B));

                    outputImage.SetPixel(x, y, color);
                }
            }

            return outputImage;
        }

        private void txtBld_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBld_Click(object sender, EventArgs e)
        {
            string txt = txtBld.Text;
            if (txt == "")
            {
                MessageBox.Show("Field Required\nPlease insert a value in range 0.00 - 1.00", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else if(!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(num < 0 || num > 1)
            {
                MessageBox.Show("Please insert a value in range 0.00 - 1.00", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img1);
                verifyImage(img2);
                imgR = blendImages(img1, img2, double.Parse(txt));
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error blending images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void verifyImage(Bitmap image)
        {
            if(image == null)
            {
                MessageBox.Show("Please insert valid images!", "Images not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new InvalidOperationException("Image not found!");
            }
        }

        private Bitmap blendImages(Bitmap img1, Bitmap img2, double num)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;
                    int R, G, B;
                    if (color1 != color2)
                    {
                        R = (int)((num * color1.R) + (1 - num) * color2.R);
                        G = (int)((num * color1.G) + (1 - num) * color2.G);
                        B = (int)((num * color1.B) + (1 - num) * color2.B);

                        if (R < 0) R = 0;
                        else if (R > 255) R = 255;
                        if (G < 0) G = 0;
                        else if (G > 255) G = 255;
                        if (B < 0) B = 0;
                        else if(B > 255) B = 255;
                        color = Color.FromArgb(R, G, B);
                    }
                    else color = color1;
                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void txtMult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultA_Click(object sender, EventArgs e)
        {
            string txt = txtMultA.Text;
            if (txt == "") txt = "1";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0)
            {
                MessageBox.Show("Enter a value greater than 1", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img1);
                img1 = multImage(img1, double.Parse(txt));
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error to divide images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap multImage(Bitmap image, double num)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;
                    int R, G, B;

                    R = (int)(color.R * num);
                    G = (int)(color.G * num);
                    B = (int)(color.B * num);

                    if(R > 255) R = 255;
                    if(G > 255) G = 255;
                    if(B > 255) B = 255;

                    colorOut = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, colorOut);
                }
            }
            return outputImage;
        }

       
        private void txtDivB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDivB_Click(object sender, EventArgs e)
        {
            string txt = txtDivB.Text;
            if (txt == "") txt = "1";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0 || num > 255)
            {
                MessageBox.Show("Please insert a value in range 1 - 255", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img2);
                img2 = divImage(img2, double.Parse(txt));
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error to divide images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap multiplyImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    R = color1.R * color2.R;
                    G = color1.G * color2.G;
                    B = color1.B * color2.B;

                    if (R < 0) R = 0;
                    else if (R > 255) R = 255;
                    if (G < 0) G = 0;
                    else if (G > 255) G = 255;
                    if (B < 0) B = 0;
                    else if (B > 255) B = 255;
                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }

            return outputImage;
        }

        private void txtMultB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultB_Click(object sender, EventArgs e)
        {
            string txt = txtMultB.Text;
            if (txt == "") txt = "1";
            else if (!double.TryParse(txt, out double num))
            {
                MessageBox.Show("Only numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num <= 0)
            {
                MessageBox.Show("Enter a value greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                verifyImage(img2);
                img2 = multImage(img2, double.Parse(txt));
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error to divide images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBinaryA_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                img1 = toBinary(img1);
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to binary image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap toBinary(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;

                    int R, G, B;

                    if (color.R >= 128 && color.G >= 128 && color.B >= 128)
                    {
                        R = 255;
                        G = 255;
                        B = 255;
                    }
                    else
                    {
                        R = 0;
                        G = 0;
                        B = 0;
                    }

                    colorOut = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private void btnBinaryB_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img2);
                img2 = toBinary(img2);
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to binary image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGrayA_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                img1 = toGray(img1);
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to binary image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap toGray(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;

                    int grayScale = (int)((color.R * 0.3) + (color.G * 0.59) + (color.B * 0.11));
                    colorOut = Color.FromArgb(grayScale, grayScale, grayScale);

                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private void btnGrayB_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img2);
                img2 = toGray(img2);
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to binary image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnNotA_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                img1 = invertImageColor(img1);
                pbA.Image = img1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to NOT image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap invertImageColor(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            int x, y;

            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    Color colorOut;

                    int R, G, B;

                    R = 255 - color.R;
                    G = 255 - color.G;
                    B = 255 - color.B;

                    colorOut = Color.FromArgb(R, G, B);
                    outputImage.SetPixel(x, y, colorOut);
                }
            }

            return outputImage;
        }

        private void btnNotB_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img2);
                img2 = invertImageColor(img2);
                pbB.Image = img2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error convert to NOT image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAND_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = andImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error AND images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap andImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            imgA = toBinary(imgA);
            imgB = toBinary(imgB);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    if(color1.R > 0 && color2.R > 0)
                    {
                        R = 255;
                    } 
                    else R = 0;

                    if (color1.G > 0 && color2.G > 0)
                    {
                        G = 255;
                    }
                    else G = 0;
                    if (color1.B > 0 && color2.B > 0)
                    {
                        B = 255;
                    }
                    else B = 0;
                   
                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = orImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error OR images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap orImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            imgA = toBinary(imgA);
            imgB = toBinary(imgB);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    if (color1.R > 0 || color2.R > 0)
                    {
                        R = 255;
                    }
                    else R = 0;

                    if (color1.G > 0 || color2.G > 0)
                    {
                        G = 255;
                    }
                    else G = 0;
                    if (color1.B > 0 || color2.B > 0)
                    {
                        B = 255;
                    }
                    else B = 0;

                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = xorImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error XOR images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap xorImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            imgA = toBinary(imgA);
            imgB = toBinary(imgB);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    if (color1.R > 0 ^ color2.R > 0)
                    {
                        R = 255;
                    }
                    else R = 0;

                    if (color1.G > 0 ^ color2.G > 0)
                    {
                        G = 255;
                    }
                    else G = 0;
                    if (color1.B > 0 ^ color2.B > 0)
                    {
                        B = 255;
                    }
                    else B = 0;

                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnNOT_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                imgR = notImages(img1, img2);
                pbResult.Image = imgR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error NOT images",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Bitmap notImages(Bitmap img1, Bitmap img2)
        {
            Bitmap imgA = resizeImage(img1);
            Bitmap imgB = resizeImage(img2);
            imgA = toBinary(imgA);
            imgB = toBinary(imgB);
            Bitmap outputImage = new Bitmap(imgA.Width, imgB.Height);

            int x, y;

            for (x = 0; x < imgA.Width; x++)
            {
                for (y = 0; y < imgA.Height; y++)
                {
                    Color color1 = imgA.GetPixel(x, y);
                    Color color2 = imgB.GetPixel(x, y);
                    Color color;

                    int R, G, B;

                    if (!(color1.R > 0 && color2.R > 0))
                    {
                        R = 255;
                    }
                    else R = 0;

                    if (!(color1.G > 0 && color2.G > 0))
                    {
                        G = 255;
                    }
                    else G = 0;
                    if (!(color1.B > 0 && color2.B > 0))
                    {
                        B = 255;
                    }
                    else B = 0;

                    color = Color.FromArgb(R, G, B);

                    outputImage.SetPixel(x, y, color);
                }
            }
            return outputImage;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                verifyImage(img1);
                verifyImage(img2);

                exportImage(imgR);

                MessageBox.Show("Success when exporting image",
                    "Image result exported to executable directory",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error export image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool exportImage(Bitmap image)
        {
            try
            {
                ImageCodecInfo myImageCodecInfo;
                Encoder myEncoder;
                EncoderParameter myEncoderParameter;
                EncoderParameters myEncoderParameters;

                // Get an ImageCodecInfo object that represents the JPEG codec.
                myImageCodecInfo = GetEncoderInfo("image/jpeg");

                myEncoder = Encoder.Quality;

                myEncoderParameters = new EncoderParameters(1);

                // Save the bitmap as a JPEG file with quality level 100.
                myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                image.Save("exported_result.jpg", myImageCodecInfo, myEncoderParameters);
                return true;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private Bitmap mirrorImages(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width * 2, image.Height);

            int x, y;
            int i = outputImage.Width - 1;

            for (x = 0; x < image.Width; x++, i--)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color color = image.GetPixel(x, y);

                    outputImage.SetPixel(x, y, color);
                    outputImage.SetPixel(i, y, color);
                }
            }
            return outputImage;
        }

        

        private Bitmap generateImage()
        {
            //By aybe - StackOverflow
            Bitmap image = new Bitmap(100, 100, PixelFormat.Format8bppIndexed);
            var bitmapData = image.LockBits(new Rectangle(Point.Empty, image.Size), ImageLockMode.ReadWrite, image.PixelFormat);
            Random random = new Random();
            byte[] buffer = new byte[image.Width * image.Height];
            random.NextBytes(buffer);
            System.Runtime.InteropServices.Marshal.Copy(buffer, 0, bitmapData.Scan0, buffer.Length);
            image.UnlockBits(bitmapData);
            return image;
        }
    }
}
