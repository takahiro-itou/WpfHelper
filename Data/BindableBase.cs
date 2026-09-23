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

using   System.ComponentModel;
using   System.Runtime.CompilerServices;

using   WpfHelper.Utils;


namespace  WpfHelper.Data  {

//========================================================================
//
//    BindableBase  class
//

public  class  BindableBase : NotifyPropertyChangedBase
{

//========================================================================
//
//    Protected Member Functions.
//

//----------------------------------------------------------------
/**   プロパティの値をセットし変更を通知する。
**
**/
protected  void
SetValue<T>(
    ref  T  fieldVar,
    T       value,
    [CallerMemberName]  System.String?  propertyName = null)
{
    if ( EqualityComparer<T>.Default.Equals(fieldVar, value)) {
        return;
    }
    fieldVar = value;
    RaisePropertyChanged(propertyName);
}


}   //  End of class  BindableBase

}   //  End of namespace  WpfHelper.Data
