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

using   System.Collections.Concurrent;
using   System.Windows.Media;


namespace  WpfHelper.Utils  {

//========================================================================
//
//    BrushCache  class
//

public  static  class  BrushCache
{

//========================================================================
//
//    Public Member Functions.
//

public  static  SolidColorBrush
GetBrush(Color  color)
{
    return  s_cache.GetOrAdd(color, c =>
        {
            SolidColorBrush brush = new SolidColorBrush(c);
            if ( brush.CanFreeze ) {
                brush.Freeze();
            }
            return ( brush );
       });
}


//========================================================================
//
//    Member Variables.
//

/**   キャッシュ。  **/
private   static  readonly
ConcurrentDictionary<Color, SolidColorBrush>    s_cache = new();


}   //  End of class  BrushCache

}   //  End of namespace  WpfHelper.Utils
