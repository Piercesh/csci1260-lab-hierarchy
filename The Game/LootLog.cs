using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game
{
    /// <summary>
    /// This interface will be added to LootLog and that it has Dispose method that will close the file and release resources.
    /// </summary>
    public interface IDisposable
    {
        void Dispose();
    }
    /// <summary>
    /// Lootlog will implement IDisposable
    /// It will also have a writer, path, count, and isClosed.
    /// </summary>
    public class LootLog : IDisposable
    {
        private StreamWriter writer;
        private string path;
        private int count;
        private bool isClosed;

        public string Path
        {
            get { return path; }
        }
        public int Count
        {
            get { return count; }
        }

        public bool IsClosed
        {
            get { return isClosed; }
        }

        /// <summary>
        /// public lootlog will get the path and set the count to 0 and isClosed to false.
        /// </summary>
        /// <param name="path"></param>
        public LootLog(string path)
        {
            this.path = path;
            this.count = 0;
            this.isClosed = false;
            writer = new StreamWriter(path);
        }
        /// <summary>
        /// Write will need to be set to void and also have LootDrop r.
        /// It will check if the LootLog is closed or if the LootDrop is null and throw exceptions accordingly.
        /// </summary>
        /// <param name="r"></param>
        /// <exception cref="ObjectDisposedException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public void Write(LootDrop r)
        {
           if (isClosed)
                throw new ObjectDisposedException(nameof(LootLog));
           if (r == null)
                throw new
                    ArgumentNullException(nameof(r));
            writer.WriteLine(r.ToString());
            writer.Flush();
            count++;
        }
        /// <summary>
        /// Dispose will be set a void and it will check if isClosed is false and if it is it will dispose the writer and set isClosed to true.
        /// </summary>
        public void Dispose()
        {
            if (!isClosed)
            {
                writer?.Dispose();
                isClosed = true;
            }
        }
    }



    
}
