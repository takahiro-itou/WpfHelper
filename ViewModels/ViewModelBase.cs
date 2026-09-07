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
using   System.Windows.Input;

using   WpfHelper.Commands;


namespace  WpfHelper.ViewModels  {

public  class  ViewModelBase : INotifyPropertyChanged
{

//========================================================================
//
//    Constructor(s) and Destructor.
//

//----------------------------------------------------------------
/**   コンストラクタ。
**
**/

public
ViewModelBase()
{
}


//========================================================================
//
//    Properties.
//

//----------------------------------------------------------------
/**
**
**/

public  event   PropertyChangedEventHandler?    PropertyChanged;



//========================================================================
//
//    Protected Member Functions.
//

//----------------------------------------------------------------
/**
**
**/

protected  virtual  INotifyCanExecuteChanged
getCommand(
        ICommand  command,
        [CallerArgumentExpression("command")] string  paramName = "")
{
    if ( command is INotifyCanExecuteChanged raiseableCommand ) {
        return ( raiseableCommand );
    }

    throw new ArgumentException(
        $"指定されたコマンドは {nameof(INotifyCanExecuteChanged)} を"
        + $"実装していません。プロパティ名: {paramName}",
        paramName);
}

//----------------------------------------------------------------
/**
**
**/

protected  virtual  void
raiseCanExecuteChanged(
        ICommand  command,
        [CallerArgumentExpression("command")] string  paramName = "")
{
    getCommand(command, paramName).raiseCanExecuteChanged();
}


//----------------------------------------------------------------
/**
**
**/

protected  virtual  void
raisePropertyChanged(
        [CallerMemberName]  System.String?  propertyName = null)
{
    PropertyChanged?.Invoke(
            this, new PropertyChangedEventArgs(propertyName));
}


}   //  End of class  ViewModelBase

}   //  End of namespace  WpfHelper.ViewModels
