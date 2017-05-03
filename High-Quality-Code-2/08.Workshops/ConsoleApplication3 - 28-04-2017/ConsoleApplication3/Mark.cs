namespace ConsoleApplication3
{
    public class Mark {
        private float value;
        private Subject subject;

        public Mark(Subject sbj, float va) {
            subject = sbj;
            value = va;
        }

        public float Value { get; set; }

        public Subject Subject { get; set; }
    }
}
