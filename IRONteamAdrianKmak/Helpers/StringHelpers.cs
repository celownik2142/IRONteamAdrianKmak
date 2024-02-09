using IRONteamAdrianKmak.Types;

namespace IRONteamAdrianKmak.Helpers
{
    public class StringHelpers
    {
        public static string CreateActionTypeMessage(ActionType action, Sex sex)
        {
            switch (action)
            {
                case ActionType.Removed:
                    {
                        return CreateRemovedMessage(sex);
                    }
                case ActionType.Added:
                    {
                        return CreateAddedMessage(sex);
                    }
                default: return string.Empty;
            }
        }

        private static string CreateRemovedMessage(Sex sex)
        {
            switch (sex)
            {
                case Sex.Male:
                    {
                        return "został usunięty z";
                    }
                case Sex.Female:
                    {
                        return "została usunięta z";
                    }
                default: return "zostało usunięte z";
            }
        }

        private static string CreateAddedMessage(Sex sex)
        {
            switch (sex)
            {
                case Sex.Male:
                    {
                        return "został dodany do";
                    }
                case Sex.Female:
                    {
                        return "została dodana do";
                    }
                default: return "zostało dodane do";
            }
        }
    }
}
