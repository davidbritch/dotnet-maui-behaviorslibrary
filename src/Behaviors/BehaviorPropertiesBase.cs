namespace Behaviors
{
	[Preserve(AllMembers = true)]
	[ContentProperty(nameof(Actions))]
	public class BehaviorPropertiesBase : BehaviorBase<VisualElement>
    {
		public static readonly BindableProperty ActionsProperty = 
            BindableProperty.Create(nameof(Actions), typeof(ActionCollection), typeof(BehaviorPropertiesBase), null);

		public ActionCollection Actions
        {
            get
            {
                return (ActionCollection)GetValue(ActionsProperty);
            }
        }

        public BehaviorPropertiesBase()
		{         
			SetValue(ActionsProperty, new ActionCollection());
		}
    }
}
