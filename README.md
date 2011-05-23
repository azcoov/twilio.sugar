# Twilio.Sugar

Take Twilio's [Rest API](http://www.twilio.com/docs/api/rest), sprinkle in some C# 4, and you've got Twilio Sugar.

# Why?

First and foremost I'm using Twilio with [SideBox](http://www.sidebox.com) because Twilio is AWESOME! and SideBox is AWESOME!

Second, I wanted to learn a bit about c# 4 dynamics and how to implement a this JSON parser with it. [Got that here]( http://stackoverflow.com/questions/3142495/deserialize-json-into-c-dynamic-object/3142540#3142540)

Thrid, I've been wanting to learn TDD and Unit Testing. The core is being tested now and I'm going back with my paint bursh to try and get 100% code coverge. Wish me luck!

# How?

Compile this class library, drop the dll into your app, and write some code:

	TwilioAccount account = new TwilioAccount();
	PhoneAutomation PhoneAutomation = new PhoneAutomation(account);
	IList<AvailablePhoneNumber> AvailablePhoneNumbers = PhoneAutomation.AvailablePhoneNumbers(AreaCode: 480);

This should get you a list of available phone numbers.