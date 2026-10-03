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


#if !NETCOREAPP

namespace  System.Runtime.CompilerServices  {

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public  sealed  class  CallerArgumentExpressionAttribute : System.Attribute
{
    public string ParameterName { get; }

    public CallerArgumentExpressionAttribute(string parameterName)
    {
        ParameterName = parameterName;
    }
}

}   //  End of namespace  System.Runtime.CompilerServices

#endif
