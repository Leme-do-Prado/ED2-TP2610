public Senha{
    int id;
    DateTime dataGerac;
    DateTime horaGerac;
    DateTime dataAtend;
    DateTime horaAtend;

    public Senha(int i){
        this.id = i;
        this.dataGerac = DateTime.Date.Now;
        this.horaGerac = DateTime.Time.Now;
    }

    public string dadosParciais(){
        return this.id + "-" + this.dataGerac + "-" + this.horaGerac;
    }

    public string dadosCompletos(){
        return this.id + "-" + this.dataGerac + "-" + this.horaGerac + "-" + this.dataAtend + "-" + this.horaAtend;
    }
}
