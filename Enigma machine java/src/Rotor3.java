
public class Rotor3 extends Rotor {
    int setting;

    public Rotor3(int a) {
        super(a);
    }

    public void rotate() {
        ++this.setting;
    }
}
