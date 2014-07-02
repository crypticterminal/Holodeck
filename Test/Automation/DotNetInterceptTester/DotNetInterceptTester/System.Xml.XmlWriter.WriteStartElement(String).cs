namespace DotNetInterceptTester.My_System.Xml.XmlWriter
{
public class WriteStartElement_System_Xml_XmlWriter_System_String
{
public static bool _WriteStartElement_System_Xml_XmlWriter_System_String( )
{
   //Parameters
   System.String localName = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlWriter.WriteStartElement(localName);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlWriter.WriteStartElement(localName);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}