using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InserindoNoHash {
  public static void main(String args) {
    String texto;
    int chave;
    int continua;
    MapaHash mapa = new MapaHash();
    Registro r;
    do {
      Console.WriteLine("Digite uma chave");
      texto = teclado.next();
      chave = Integer.parseInt(texto);
      Console.WriteLine("Digite um valor");
      texto = teclado.next();
      r = new Registro(chave, texto);
      mapa.put(r);
      Console.WriteLine("Continua? (1-sim / 0- nao)");
      continua = Integer.parseInt(teclado.next());
    } while (continua != 0);
    Console.WriteLine("========================================");
    do {
      Console.WriteLine("Digite uma chave");
      chave = Integer.parseInt(teclado.next());
      if (chave != -1) {
        r = mapa.get(chave);
        if (r != null) {
          Console.WriteLine("Registro = " + r.getValue());
        } else {
          Console.WriteLine("Nao existe");
        }
      }
    } while (chave != -1);
    teclado.close();
  }
}
