using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Temporizador
    {
        private int intervalo;
        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador TiempoCumplido;
        private CancellationToken cancellation;
        private CancellationTokenSource cancellationSource;
        private Task hilo;
        public Temporizador(int intervalo) 
        {
            this.intervalo = intervalo;
        }
        public bool EstaActivo { get  { return hilo is not null && hilo.Status == TaskStatus.Running; } }

        private void CorrerTiempo()
        {
            while(TiempoCumplido is not null && !cancellation.IsCancellationRequested)
            {
                TiempoCumplido.Invoke();
                Thread.Sleep(intervalo);
            }
            
        }

        public void IniciarTemporizador()
        {
            if(!EstaActivo)
            {
                cancellationSource = new CancellationTokenSource();
                cancellation = cancellationSource.Token;
                hilo = new Task(CorrerTiempo);
                hilo.Start();
            }
                     
        }
        public void DetenerTemporizador()
        {
            if(EstaActivo)
            {
                cancellationSource.Cancel();
            }
        }
        

    }
}
