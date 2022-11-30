
public class Reflector {
    char ltr;
    String alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    String b = "EJMZALYXVBWFCRQUONTSPIKHGD";
    String c = "YRUHQSLDPXNGOKMIEBFZCWVJAT";

    public Reflector(char a) {
        this.ltr = a;
    }

    public char shift(char a) {
        for(int i = 0; i < 24; ++i) {
            if (a == this.alph.charAt(i)) {
                if (this.ltr == 'b') {
                    a = this.b.charAt(i);
                } else {
                    a = this.c.charAt(i);
                }
            }
        }

        return a;
    }
}
