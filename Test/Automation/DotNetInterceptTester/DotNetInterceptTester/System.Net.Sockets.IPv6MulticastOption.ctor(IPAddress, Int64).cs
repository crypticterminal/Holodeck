namespace DotNetInterceptTester.My_System.Net.Sockets.IPv6MulticastOption
{
public class ctor_System_Net_Sockets_IPv6MulticastOption_System_Net_IPAddress_System_Int64
{
public static bool _ctor_System_Net_Sockets_IPv6MulticastOption_System_Net_IPAddress_System_Int64( )
{
   //Parameters
   System.Net.IPAddress group = null;
   System.Int64 ifindex = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Net.Sockets.IPv6MulticastOption.ctor(group,ifindex);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Net.Sockets.IPv6MulticastOption.ctor(group,ifindex);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}