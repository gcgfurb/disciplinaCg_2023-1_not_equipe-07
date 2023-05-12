#define CG_Debug

using CG_Biblioteca;
using OpenTK.Graphics.OpenGL4;

namespace gcgcg
{
    internal class Circulo : Objeto
    {
        public Circulo(Objeto paiRef, float angulo, double raio) : base(paiRef)
        {
            base.PrimitivaTipo = PrimitiveType.Points;
            base.PrimitivaTamanho = 5;

            for (int i = 0; i < 360; i += 5)
            {
                Ponto4D pto = Matematica.GerarPtosCirculo(i, raio);
                base.PontosAdicionar(pto);
            }
        }

        public void Atualizar()
        {

            base.ObjetoAtualizar();
        }

    }
}