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
//    IntToBoolConverter  class
//

[ValueConversion(typeof(int), typeof(bool))]
public  class  IntToBoolConverter : IValueConverter
{

//----------------------------------------------------------------
/**   数値をブールに変換する。
**
**    ビューモデルからビュー（画面）への対応。
**/
public  object
Convert(
        object      value,
        Type        targetType,
        object      parameter,
        CultureInfo culture)
{
    if ( value is int intValue && parameter != null ) {
        if ( int.TryParse(parameter.ToString() ?? "", out int paramValue) )
        {
            return ( intValue == paramValue );
        } else {
            //  パース失敗時のエラーハンドリング。  //
            return ( false );
        }
    }
    return ( false );
}


//----------------------------------------------------------------
/**   ブールを数値に変換する。
**
**    ビュー（画面）からビューモデルへの対応。
**  ラジオボタン等がクリックされたときに、
**  選択されたボタンに応じて数値をビューモデルに書き戻す。
**/
public  object
ConvertBack(
        object      value,
        Type        targetType,
        object      parameter,
        CultureInfo culture)
{
    if ( value is bool boolValue && boolValue && parameter != null ) {
        if ( int.TryParse(parameter.ToString() ?? "", out int paramValue) )
        {
            return ( paramValue );
        } else {
            //  パース失敗時のエラーハンドリング。  //
            return ( System.Windows.Data.Binding.DoNothing );
        }
    }

    return ( System.Windows.Data.Binding.DoNothing );
}


}   //  End of class  IntToBoolConverter

}   //  End of namespace  WpfHelper.Data
