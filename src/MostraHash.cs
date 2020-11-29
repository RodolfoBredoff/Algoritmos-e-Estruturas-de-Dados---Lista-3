using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MostraHash {
  public static void main(String args) {
    String s1, s2, s3, s4;
    s1 = "aa";
    s2 = "ab";
    s3 = "ac";
    s4 = "ad";
     Console.WriteLine("HashCode : " + s1.hashCode());
     Console.WriteLine("HashCode : " + s2.hashCode());
     Console.WriteLine("HashCode : " + s3.hashCode());
     Console.WriteLine("HashCode : " + s4.hashCode());
  }
}
