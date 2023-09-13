using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbut.Classes
{
    public class Zar
    {
        int _sayi;  // 0
        string _yuz; // class'ın global değişkenleri (alanları)

        public string Yuz
        {
            get
            {
                _yuz = "";
                switch (_sayi)
                {
                    case 1:
                        _yuz += "\n---";
                        _yuz += "\n-*-";
                        _yuz += "\n---";
                        break;
                    case 2:
                        _yuz += "\n*--";
                        _yuz += "\n---";
                        _yuz += "\n--*";
                        break;
                    case 3:
                        _yuz += "\n*--";
                        _yuz += "\n-*-";
                        _yuz += "\n--*";
                        break;
                    case 4:
                        _yuz += "\n*-*";
                        _yuz += "\n---";
                        _yuz += "\n*-*";
                        break;
                    case 5:
                        _yuz += "\n*-*";
                        _yuz += "\n-*-";
                        _yuz += "\n*-*";
                        break;
                    case 6:
                        _yuz += "\n***";
                        _yuz += "\n---";
                        _yuz += "\n***";
                        break;
                }
                return _yuz;
            }
        }

        //Random _rastgele;  // Null bu şekilde değil alttakı gıbı daha ıyıdır
        Random _rastgele = new Random();

        //*--
        //-*-
        //--*

        public int At()  // behavior (davranış)
        {
            //_rastgele = new Random(); // Burda yaparsak istenilen sonucu vermeyebiliyor
            _sayi = _rastgele.Next(1, 7);
            return _sayi;
        }
        
    }
}
