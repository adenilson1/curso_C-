using System.Data;
using Internal;
using System;


interface IDisp_USB
{
    void Ligar();
}

class Disp_USB : IDisp_USB
{
    public void Ligar()
    {
        Console.WriteLine("USB Ligaado");
    }
}

interface PortaHDMI
{
    void LigarHDMI();
}

class USBpraHDMI : PortaHDMI //Adapter
{
    private IDisp_USB usb;

    public USBpraHDMI(IDisp_USB disp_USB)
    {
        usb = disp_USB;
    }

    public void LigarHDMI()
    {
        usb.Ligar();
        Console.WriteLine("USB conectado pelo adaptador HDMI");
    }
}

class Principal
{
    static void Main()
    {
        PortaHDMI hdmi = new USBpraHDMI(new Disp_USB());
        hdmi.LigarHDMI();
        
    }
}