using System;

namespace DotNetInterceptTester.My_System.ComponentModel.EnumConverter
{
public class ConvertFromInvariantString_System_ComponentModel_EnumConverter_System_ComponentModel_ITypeDescriptorContext_System_String
{
public static bool _ConvertFromInvariantString_System_ComponentModel_EnumConverter_System_ComponentModel_ITypeDescriptorContext_System_String( )
{

   //class object
    System.ComponentModel.EnumConverter _System_ComponentModel_EnumConverter = new System.ComponentModel.EnumConverter();

   //Parameters
   System.ComponentModel.ITypeDescriptorContext context = null;
   System.String text = null;

   //ReturnType/Value
   System.Object returnVal_Real = null;
   System.Object returnVal_Intercepted = null;

   //Exception
   System.Exception exception_Real = null;
   System.Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnVal_Real = _System_ComponentModel_EnumConverter.ConvertFromInvariantString(context,text);
   }

   catch( System.Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnVal_Intercepted = _System_ComponentModel_EnumConverter.ConvertFromInvariantString(context,text);
   }

   catch( System.Exception e )
   {
      exception_Intercepted = e;
   }


   return( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}