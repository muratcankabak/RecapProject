using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages // Bir model classı olmadığı için ve içerisinde 
                          //birden çok mesaj fieldı
                          //barındıracağı için çoğul isimle oluşturduk. 
    {
        public static string Error = "Bilinmeyen bir hata oluştu.";
        public static string Success = "İşlem başarılı.";
    }
}
