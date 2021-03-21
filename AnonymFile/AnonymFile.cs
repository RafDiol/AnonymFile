using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Metadata;

namespace AnonymFile
{
    public static class AnonymFile
    {
        /// <summary>
        /// Overrides the original file with the no-metadata file
        /// </summary>
        /// <param name="filepath"></param>
        public static void deleteMetadata(string filepath)
        {
            if (File.Exists(filepath))
            {
                using (Metadata metadata = new Metadata(filepath))
                {
                    metadata.Sanitize();

                    metadata.Save();
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        /// <summary>
        /// Saves the no-metadata file to the outputFilepath
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="outputFilepath"></param>
        public static void deleteMetadata(string filepath, string outputFilepath)
        {
            if (File.Exists(filepath))
            {
                using (Metadata metadata = new Metadata(filepath))
                {
                    metadata.Sanitize();

                    metadata.Save(outputFilepath);
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        /// <summary>
        /// Saves the no-metadata file to the document stream
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="document"></param>
        public static void deleteMetadata(string filepath, Stream document)
        {
            if (File.Exists(filepath))
            {
                using (Metadata metadata = new Metadata(filepath))
                {
                    metadata.Sanitize();

                    metadata.Save(document);
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
