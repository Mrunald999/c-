import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class Testing {
	static WebDriver  driver;

	public static void main(String[] args) {

	}

	public static void setup() {

		driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("https://ecommercepractice.letskodeit.com/");
	}
	
		

	}

