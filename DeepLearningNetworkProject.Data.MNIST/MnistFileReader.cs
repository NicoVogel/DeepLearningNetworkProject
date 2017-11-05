using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLNP.Data.MNIST
{
    public class MnistFileReader
    {




        #region Public Methods


        public MnistFile ReadFile(String imagesPath, String lablesPath)
        {
            var mnistFile = new MnistFile();

            try
            {
                Console.WriteLine(String.Format("Start reading the MNIST Files. Images file path: {0}, Lables file path: {1}", imagesPath, lablesPath));
                
                var ifsLabels = new FileStream(lablesPath, FileMode.Open); // test labels
                var ifsImages = new FileStream(imagesPath, FileMode.Open); // test images

                var brLabels = new BinaryReader(ifsLabels);
                var brImages = new BinaryReader(ifsImages);

                int magic1 = brImages.ReadInt32(); // discard
                int numImages = brImages.ReadInt32();
                int numRows = brImages.ReadInt32();
                int numCols = brImages.ReadInt32();

                int magic2 = brLabels.ReadInt32();
                int numLabels = brLabels.ReadInt32();

                byte[][] pixels = new byte[28][];
                for (int i = 0; i < pixels.Length; ++i)
                    pixels[i] = new byte[28];

                // each test image
                for (int di = 0; di < 10000; ++di)
                {
                    for (int i = 0; i < 28; ++i)
                    {
                        for (int j = 0; j < 28; ++j)
                        {
                            byte b = brImages.ReadByte();
                            pixels[i][j] = b;
                        }
                    }

                    byte lbl = brLabels.ReadByte();

                    DigitImage dImage =
                      new DigitImage(pixels, lbl);
                    Console.WriteLine(dImage.ToString());
                    Console.ReadLine();
                } // each image

                ifsImages.Close();
                brImages.Close();
                ifsLabels.Close();
                brLabels.Close();

                Console.WriteLine("\nEnd\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(
                    String.Format(
                        "Failed to load the images and labes from the given paths. Images file path: {0}, Lables file path: {1}, Exception message: {2}", 
                        imagesPath, lablesPath, ex.Message), 
                    ex);
            }

            return mnistFile;
        }


        #endregion


    }
}
