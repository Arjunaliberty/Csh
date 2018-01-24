using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ISerializerDB
    {
        /// <summary>
        /// Метод для загрузки данных из файла
        /// </summary>
        /// <returns></returns>
        List<Student> Load();

        /// <summary>
        /// Метод для сохранения данный в файл
        /// </summary>
        /// <param name="students"></param>
        void Save(List<Student> students);
    }
}
