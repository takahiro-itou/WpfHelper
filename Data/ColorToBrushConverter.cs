//  -*-  coding: utf-8-with-signature-unix     -*-  //
/*************************************************************************
**                                                                      **
**                  ----   WPF  Helper  Library   ----                  **
**                                                                      **
**          Copyright (C), 2026-2026, Takahiro Itou                     **
**          All Rights Reserved.                                        **
**                                                                      **
**          License: (See COPYING or LICENSE files)                     **
**          GNU Affero General Public License (AGPL) version 3,         **
**          or (at your option) any later version.                      **
**                                                                      **
*************************************************************************/

using   System.Globalization;
using   System.Windows.Data;


namespace  WpfHelper.Data  {

//========================================================================
//
//    ColorToBrushConverter  class
//

[ValueConversion(typeof(int), typeof(bool))]
public  class  ColorToBrushConverter : IValueConverter
{

//----------------------------------------------------------------
/**   カラーをブラシに変換する。
**
**/
public  object
Convert(
        object      value,
        Type        targetType,
        object      parameter,
        CultureInfo culture)
{
}


//----------------------------------------------------------------
/**
**
**/
public  object
ConvertBack(
        object      value,
        Type        targetType,
        object      parameter,
        CultureInfo culture)
{
    throw  new NotImplementedException();
}


}   //  End of class  ColorToBrushConverter

}   //  End of namespace  WpfHelper.Data
