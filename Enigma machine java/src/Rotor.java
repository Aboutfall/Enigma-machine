
public class Rotor {
    String I = "ekmflgdqvzntowyhxuspaibrcj";
    boolean t = false;
    int setting;

    public Rotor(int a) {
        this.setting = a;
    }

    public char io(char a) {
        this.setting %= 26;
        int b = a - 97;
        b = (b + this.setting) % 26;
        a = this.I.charAt(b);
        b = a - 97;
        b = (b + 26 - this.setting) % 26 + 97;
        a = (char)b;
        if (this.t) {
            this.t = false;
        } else {
            ++this.setting;
            this.t = true;
        }

        return a;
    }
}
