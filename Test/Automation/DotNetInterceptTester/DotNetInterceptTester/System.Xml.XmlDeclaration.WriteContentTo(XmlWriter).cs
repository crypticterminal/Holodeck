namespace DotNetInterceptTester.My_System.Xml.XmlDeclaration
{
public class WriteContentTo_System_Xml_XmlDeclaration_System_Xml_XmlWriter
{
public static bool _WriteContentTo_System_Xml_XmlDeclaration_System_Xml_XmlWriter( )
{
   //Parameters
   System.Xml.XmlWriter w = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlDeclaration.WriteContentTo(w);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlDeclaration.WriteContentTo(w);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}