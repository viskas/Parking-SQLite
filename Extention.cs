using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking
{
    public static class Extention
    {
        public static Char EditKeyPress(this TextBox m_Ed, System.Windows.Forms.KeyPressEventArgs m_KeyPres, Boolean m_NotAllowDecimalSeparator = false, Boolean m_NotAllowSign = false)
        {
            // Получаем текущие настройки
            var nfi = new System.Globalization.NumberFormatInfo();
            //char ndc = (nfi.NumberDecimalSeparator.ToCharArray())[0];
            char ndc = ',';

            // Меняем точку или запятую на системный разделитель
            // Меняем точку или запятую на запятую
            if ((m_KeyPres.KeyChar == '.') || (m_KeyPres.KeyChar == ','))
                m_KeyPres.KeyChar = ndc;



            if (m_NotAllowDecimalSeparator)////Запрет на ввод  разделитель
            {

                if (m_NotAllowSign)
                {
                    if ((m_KeyPres.KeyChar != 8) &&
                        (m_KeyPres.KeyChar != '/') && (m_KeyPres.KeyChar != '*') &&
                        (m_KeyPres.KeyChar != '-') && (m_KeyPres.KeyChar != '+') &&
                        (m_KeyPres.KeyChar < 48 || m_KeyPres.KeyChar > 57 || m_KeyPres.KeyChar == ndc))
                        m_KeyPres.KeyChar = '\0';
                }
                else
                {
                    if ((m_KeyPres.KeyChar != 8) &&
                        (m_KeyPres.KeyChar < 48 || m_KeyPres.KeyChar > 57 || m_KeyPres.KeyChar == ndc))
                        m_KeyPres.KeyChar = '\0';
                }
            }

            else
            {
                //Запрет на ввод более одной точки
                if ((m_KeyPres.KeyChar == ndc) && (m_Ed.Text.IndexOf(ndc) >= 0))
                    return m_KeyPres.KeyChar = '\0';

                if (m_NotAllowSign)
                {
                    if ((m_KeyPres.KeyChar != 8) && (m_KeyPres.KeyChar != ndc) &&
                        (m_KeyPres.KeyChar != '/') && (m_KeyPres.KeyChar != '*') &&
                        (m_KeyPres.KeyChar != '-') && (m_KeyPres.KeyChar != '+') &&
                        (m_KeyPres.KeyChar < 48 || m_KeyPres.KeyChar > 57))
                        m_KeyPres.KeyChar = '\0';
                }
                else
                {
                    if ((m_KeyPres.KeyChar != 8) && (m_KeyPres.KeyChar != ndc) &&
                        (m_KeyPres.KeyChar < 48 || m_KeyPres.KeyChar > 57))
                        m_KeyPres.KeyChar = '\0';
                }
            }

            return m_KeyPres.KeyChar;
        }
    }
}
