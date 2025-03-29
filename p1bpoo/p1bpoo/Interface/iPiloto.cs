interface iPiloto
{
    string Nombre { get; set; }
    int Edad { get; set; }
    string TipoLicencia { get; set; } //Tipo A,C,B,M

    void MostrarInformacion();
}