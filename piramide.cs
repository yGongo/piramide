
namespace Piramide{
    public static class Piramide {

        public static int Piani( int mattoni )
        {
            int floors = 0;
            while (mattoni >= (2 * floors + 1) * (2 * floors + 1)){

                floors++;
                mattoni -= (2 * floors - 1) * (2 * floors - 1);

            }
            return floors;
        }
        public static int Rimanenti( int mattoni )
        {
            int floors = Piani(mattoni);
            int mattoniUtilizzati = 0;
            for (int i = 1; i <= floors; i++){

                mattoniUtilizzati += (2 * i - 1) * (2 * i - 1);

            }
            return mattoni - mattoniUtilizzati;
        }

    }
}