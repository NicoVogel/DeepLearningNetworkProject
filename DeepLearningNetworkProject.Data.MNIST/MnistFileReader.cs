
using DLNP.Entities.Interfaces.Data;
using System;
using System.IO;
using System.Collections.Generic;
using DLNP.Entities.Factory;

namespace DLNP.Data.MNIST
{
    public class MnistFileReader : IFileReader
    {

        #region Constructors




        #endregion


        #region Public Methods



        public IList<INetworkInputData> ReadFile(String imagesPath, String lablesPath)
        {
            IList<INetworkInputData> networkData = null;
            FileStream ifsLabels = null;
            FileStream ifsImages = null;
            BinaryReader brLabels = null;
            BinaryReader brImages = null;


            try
            {
                Console.WriteLine(String.Format("Start reading the MNIST Files. Images file path: {0}, Lables file path: {1}", imagesPath, lablesPath));
                
                ifsLabels = new FileStream(lablesPath, FileMode.Open); // test labels
                ifsImages = new FileStream(imagesPath, FileMode.Open); // test images

                brLabels = new BinaryReader(ifsLabels);
                brImages = new BinaryReader(ifsImages);

                networkData = readFileInformation(brLabels, brImages);


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
            finally
            {
                closeIfNotNull(ifsImages, brLabels, ifsLabels, brLabels);
            }

            return networkData;
        }


        #endregion

        #region Private Methods



        private IList<INetworkInputData> readFileInformation(BinaryReader brLabels, BinaryReader brImages)
        {
            var networkData = BusinessLayerFactory.CreateList<INetworkInputData>();


            int magic1 = brImages.ReadInt32(); // discard
            int numImages = brImages.ReadInt32();
            int numRows = brImages.ReadInt32();
            int numCols = brImages.ReadInt32();

            int magic2 = brLabels.ReadInt32();
            int numLabels = brLabels.ReadInt32();
            
            if(numImages != numLabels)


            // each test image
            for (int di = 0; di < numImages; ++di)
            {
                var dataSet = DataLayerFactory.CreateNetworkInputData();
                dataSet.initDoubleArray(numRows, numCols);

                for (int i = 0; i < numRows; ++i)
                {
                    for (int j = 0; j < numCols; ++j)
                    {
                        dataSet.ImageNumbers[i][j] = brImages.ReadByte() / 255.0;
                    }
                }
                
                dataSet.ExpectedResult = brLabels.ReadByte();
                networkData.Add(dataSet);
            } // each image


            return networkData;
        }


        /// <summary>
        /// dispose all parameter objects which are not null
        /// </summary>
        /// <param name="dispObjs"></param>
        private void closeIfNotNull(params IDisposable[] dispObjs)
        {
            foreach (var dispObj in dispObjs)
            {
                if (dispObj != null)
                    dispObj.Dispose();
            }
        }
        

        #endregion




    }
}
