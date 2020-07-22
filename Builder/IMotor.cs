namespace Builder
{
    internal interface IMotor
    {
        string MostrarEspecificaciones();
    }

    internal class MotorBasico : IMotor
    {
        public string MostrarEspecificaciones()
        {
            return "Motor de 4 cilíndors";
        }
    }

    internal class MotorEspecial : IMotor
    {
        public string MostrarEspecificaciones()
        {
            return "Motor V12";
        }
    }
}
