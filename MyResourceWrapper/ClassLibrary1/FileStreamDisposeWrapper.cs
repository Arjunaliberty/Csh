using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FileStreamDisposeWrapper : IDisposable
    {
        /// <summary>
        /// Поле хранящее структуру типа IntPtr
        /// </summary>
        private IntPtr intPtr;
        /// <summary>
        /// Поле для хранения стостояния объекта, был ли он удален или еще нет
        /// </summary>
        private bool isDisposed = false;

        /// <summary>
        /// Конструктор типа IntPtrWrapper
        /// </summary>
        /// <param name="intPtr"></param>
        public FileStreamDisposeWrapper(IntPtr intPtr)
        {
            this.intPtr = intPtr;
        }

        private void Dispose(bool isDisposing)
        {
            Object obj = intPtr.GetType();

            if (!isDisposed)
            {
                if (isDisposing)
                {

                }

                unsafe
                {
                    
                }
               
            }
        }

        /// <summary>
        /// Метод Dispose вызываемы программистом вручную для освобождения ресурсов
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Вызов метода Dispode в деструкторе при финализации объекта (т.е. при обработке объекта garbage collector)
        /// </summary>
        ~FileStreamDisposeWrapper()
        {
            Dispose(false);
        }
    }
}
