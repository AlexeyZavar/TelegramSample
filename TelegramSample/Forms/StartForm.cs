using TelegramBotBase.Base;
using TelegramBotBase.Form;

namespace TelegramSample.Forms;

public class StartForm : AutoCleanForm
{
    public override async Task Render(MessageResult message)
    {
        var form = new ButtonForm();
        form.AddButtonRow("Click me!", "", "https://radolyn.com");

        await Device.Send("Here's some text.", form);
    }
}
