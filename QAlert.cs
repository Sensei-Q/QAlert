// QAlert v1.0 (c) 2022 Sensei (aka 'Q')
// Shows an alert with a user message and an optional title.
//
// Usage:
// QAlert <message>
// QAlert <message> <caption>
//
// Examples:
// QAlert "Disk will be formated!" "WARNING!"
//
// Compilation:
// %SYSTEMROOT%\Microsoft.NET\Framework\v3.5\csc QAlert.cs
// %SYSTEMROOT%\Microsoft.NET\Framework\v3.5\csc /target:winexe QAlert.cs

using System;
using System.Windows.Forms;

public static class QAlert {
   public static void Main( string [] args ) {
      if( args.Length == 2 ) {
         MessageBox.Show( args[ 0 ], args[ 1 ] );
      } else if( args.Length == 1 ) {
         MessageBox.Show( args[ 0 ] );
      } else {
         Console.WriteLine( "QAlert v1.0 (c) 2022 Sensei (aka 'Q')" );
         Console.WriteLine( "Shows an alert with a user message and an optional title." );
         Console.WriteLine();
         Console.WriteLine( "Usage:" );
         Console.WriteLine( "QAlert <message>" );
         Console.WriteLine( "QAlert <message> <caption>" );
      }
   }
}
