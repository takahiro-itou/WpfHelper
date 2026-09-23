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


namespace  WpfHelper.Utils  {

//========================================================================
//
//    NotifyPropertyChangedBase  class
//

public  class  NotifyPropertyChangedBase : INotifyPropertyChanged
{

//========================================================================
//
//    Properties.
//

//----------------------------------------------------------------
/**   プロパティが変化したことを通知するイベント。
**
**/
public  event   PropertyChangedEventHandler?    PropertyChanged;


//========================================================================
//
//    Protected Member Functions.
//

//----------------------------------------------------------------
/**   プロパティの変更通知イベントを発火させる。
**
**/
protected  virtual  void
RaisePropertyChanged(
        [CallerMemberName]  System.String?  propertyName = null)
{
    PropertyChanged?.Invoke(
            this, new PropertyChangedEventArgs(propertyName));
}


}   //  End of class  NotifyPropertyChangedBase

}   //  End of namespace  WpfHelper.Utils
