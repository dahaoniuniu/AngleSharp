﻿namespace AngleSharp.DOM.Html
{
    using System;

    /// <summary>
    /// Represents the select HTML element.
    /// </summary>
    [DomName("HTMLSelectElement")]
    public interface IHtmlSelectElement : IHtmlElement
    {
        /// <summary>
        /// Gets or sets the autofocus HTML attribute, which indicates whether the
        /// control should have input focus when the page loads.
        /// </summary>
        [DomName("autofocus")]
        Boolean Autofocus { get; set; }

        /// <summary>
        /// Gets or sets if the button is enabled or disabled.
        /// </summary>
        [DomName("disabled")]
        Boolean IsDisabled { get; set; }

        /// <summary>
        /// Gets the associated HTML form element.
        /// </summary>
        [DomName("form")]
        IHtmlFormElement Form { get; }

        /// <summary>
        /// Gets the list of assigned labels.
        /// </summary>
        [DomName("labels")]
        INodeList Labels { get; }

        /// <summary>
        /// Gets or sets the name of the element.
        /// </summary>
        [DomName("name")]
        String Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [DomName("value")]
        String Value { get; set; }

        /// <summary>
        /// Gets the type of input element (select).
        /// </summary>
        [DomName("type")]
        String Type { get; }

        /// <summary>
        /// Gets or sets if the field is required.
        /// </summary>
        [DomName("required")]
        Boolean IsRequired { get; set; }

        /// <summary>
        /// Gets the set of options that are selected.
        /// </summary>
        [DomName("selectedOptions")]
        IHtmlCollection SelectedOptions { get; }

        /// <summary>
        /// Gets or sets the display size of the element.
        /// </summary>
        [DomName("size")]
        Int32 Size { get; set; }
        
        /// <summary>
        /// Gets the set of option elements contained by this element. 
        /// </summary>
        [DomName("options")]
        IHtmlOptionsCollection Options { get; }
        
        /// <summary>
        /// Gets the number of option elements in this select element.
        /// </summary>
        [DomName("length")]
        Int32 Length { get; }
        
        /// <summary>
        /// Gets or sets the multiple HTML attribute, whichindicates whether multiple items can be selected.
        /// </summary>
        [DomName("multiple")]
        Boolean IsMultiple { get; set; }

        /// <summary>
        /// Gets the index of the first selected option element.
        /// </summary>
        [DomName("selectedIndex")]
        Int32 SelectedIndex { get; }

        /// <summary>
        /// Gets or sets an HTML option element at the specified index.
        /// </summary>
        /// <param name="index">The index of the element.</param>
        /// <returns>The option at the given position.</returns>
        IHtmlOptionElement this[UInt32 index] { get; set; }

        /// <summary>
        /// Adds an option element to the options collection.
        /// </summary>
        /// <param name="element">The element to add.</param>
        /// <param name="before">The optional reference element for inserting.</param>
        [DomName("add")]
        void AddOption(IHtmlOptionElement element, IHtmlElement before = null);

        /// <summary>
        /// Adds an options group element to the options collection.
        /// </summary>
        /// <param name="element">The element to add.</param>
        /// <param name="before">The optional reference element for inserting.</param>
        [DomName("add")]
        void AddOption(IHtmlOptionsGroupElement element, IHtmlElement before = null);

        /// <summary>
        /// Removes an element from the options collection.
        /// </summary>
        /// <param name="index">The index of the element of remove.</param>
        [DomName("remove")]
        void RemoveOptionAt(Int32 index);

        /// <summary>
        /// Gets a value if the current element validates.
        /// </summary>
        [DomName("willValidate")]
        Boolean WillValidate { get; }

        /// <summary>
        /// Gets the current validation state of the current element.
        /// </summary>
        [DomName("validity")]
        IValidityState Validity { get; }

        /// <summary>
        /// Gets the current validation message.
        /// </summary>
        [DomName("validationMessage")]
        String ValidationMessage { get; }

        /// <summary>
        /// Checks the validity of the current element.
        /// </summary>
        /// <returns>True if the object is valid, otherwise false.</returns>
        [DomName("checkValidity")]
        Boolean CheckValidity();

        /// <summary>
        /// Sets a custom validation error. If this is not the empty string,
        /// then the element is suffering from a custom validation error.
        /// </summary>
        /// <param name="error">The error message to use.</param>
        [DomName("setCustomValidity")]
        void SetCustomValidity(String error);
    }
}
