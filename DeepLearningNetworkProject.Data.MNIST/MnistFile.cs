
using DLNP.Entities.Interfaces.Data;
using System.Collections.Generic;

namespace DLNP.Data.MNIST
{
    public class MnistFile
    {

        #region Private Variables


        private IList<INetworkInputData> m_images;


        #endregion

        #region Properties


        /// <summary>
        /// Some number from the images file
        /// </summary>
        public int MagicImages { get; set; }

        /// <summary>
        /// The amount of images in the file
        /// </summary>
        public int NumImages { get; set; }

        /// <summary>
        /// The row count per image
        /// </summary>
        public int NumRows { get; set; }

        /// <summary>
        /// The colum count per image
        /// </summary>
        public int NumColums { get; set; }

        /// <summary>
        /// Some number from the labels file
        /// </summary>
        public int MagicLables { get; set; }

        /// <summary>
        /// The amount of labels in the file
        /// </summary>
        public int NumLables { get; set; }

        public IList<INetworkInputData> Images
        {
            get
            {
                if (m_images == null)
                    m_images = new List<INetworkInputData>();
                return m_images;
            }
        }


        #endregion

        #region Constructors



        /// <summary>
        /// default constructor
        /// </summary>
        public MnistFile()
        {

        }


        #endregion

    }
}
