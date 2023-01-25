using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset {
    class ogrenci {
    private string ad;
    private string soyad;
    private string alan;
    private int yas;
    public string adi { 
    get { return ad; } set { ad = value; } }
    public string soyadi { 
    get { return soyad; } set { soyad = value; } }
    public string alani { 
    get { return alan; } set { alan = value; } }
    public int yasi { 
    get { return yas; } set { yas = value; } }
} }
