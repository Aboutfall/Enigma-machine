public class Enigma {
    String text;
    String ctext = "";
    int ltcount = 0;
    boolean r1 = false;
    boolean r2 = false;

    public Enigma(String a, int b, int e, int d, char f) {
        this.text = a;
        Rotor1 fast = new Rotor1(b);
        Rotor2 medium = new Rotor2(e);
        Rotor3 slow = new Rotor3(d);
        Reflector r = new Reflector(f);

        for(int i = 0; i < this.text.length(); ++i) {
            char c = a.charAt(i);
            c = (char)(122 - c + 97);
            c = fast.io(c);
            if (fast.setting == 0) {
                this.r1 = true;
            }

            if (this.r1) {
                medium.rotate();
                this.r1 = false;
            }

            medium.io(c);
            if (medium.setting == 0) {
                this.r2 = true;
            }

            if (this.r2) {
                slow.rotate();
                this.r2 = false;
            }

            slow.io(c);
            r.shift(c);
            slow.io(c);
            medium.io(c);
            fast.io(c);
            c = (char)(122 - c + 97);
            if (this.ltcount == 4) {
                this.ctext = this.ctext + c;
                this.ctext = this.ctext + " ";
                this.ltcount = 0;
            } else {
                this.ctext = this.ctext + c;
                ++this.ltcount;
            }
        }

        System.out.println(this.ctext);
    }

    public String toString() {
        return "Enigma{text='" + this.text + "'}";
    }
}
