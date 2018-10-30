package apsmilkes;

abstract class Felino {

    public abstract double acao();
}

class Gato extends Felino {

    public double acao() {
        return 20.0;
    }
}

class Leopardo extends Felino {

    public double acao() {
        return 0.5;
    }
}
