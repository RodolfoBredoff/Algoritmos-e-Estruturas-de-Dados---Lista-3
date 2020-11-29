using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MinhaApp {
  public static void main(String args) {
    Scanner teclado = new Scanner();
    int key;
    Registro r1 = new Registro(789, "Registro 1");
    Registro r2 = new Registro(889, "Registro 2");
     Console.WriteLine(r1.hashCode());
     Console.WriteLine(r2.hashCode());
    // Registro r1, r2, r3, r4;
    MapaHash mapa = new MapaHash();
    mapa.put(new Registro(7865, "Isidro"));
    mapa.put(new Registro(123, "Josineidson"));
    mapa.put(new Registro(987, "Nilsonclecio"));
    mapa.put(new Registro(9832, "Deosdedite"));
    do {
       Console.WriteLine("Digite um codigo de registro");
      key = teclado.nextInt();
      if (key != -1) {
        Registro r = mapa.get(key);
        if (r != null) {
           Console.WriteLine("Registro Recuperado = " + r.getKey() + " - " + r.getValue());
        } else {
           Console.WriteLine("Registro nao existente");
        }
      }
    } while (key != -1);
    teclado.close();
  }
}
