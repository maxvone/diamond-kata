namespace DiamonKata;

public class DiamondBuilderTests
{
	[Fact]
	public void Build_GivenA_ReturnsSingleA()
	{
		//Arrange
		string expected = "A";

		//Act
		string result = DiamondBuilder.Build('A');

		//Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void Build_GivenB_ReturnsCorrectDiamond()
	{
		// Arrange
		var expected = " A \n" +
					   "B B\n" +
					   " A ";

		// Act
		var result = DiamondBuilder.Build('B');

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void Build_GivenC_ReturnsCorrectDiamond()
	{
		// Arrange
		var expected = "  A  \n" +
					   " B B \n" +
					   "C   C\n" +
					   " B B \n" +
					   "  A  ";

		// Act
		var result = DiamondBuilder.Build('C');

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void Build_GivenE_ReturnsCorrectDiamond()
	{
		// Arrange
		var expected = "    A    \n" +
					   "   B B   \n" +
					   "  C   C  \n" +
					   " D     D \n" +
					   "E       E\n" +
					   " D     D \n" +
					   "  C   C  \n" +
					   "   B B   \n" +
					   "    A    ";

		// Act
		var result = DiamondBuilder.Build('E');

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void Build_GivenZ_ReturnsCorrectDiamond()
	{
		// Arrange
		var expected =
			"                         A                         \n" +
			"                        B B                        \n" +
			"                       C   C                       \n" +
			"                      D     D                      \n" +
			"                     E       E                     \n" +
			"                    F         F                    \n" +
			"                   G           G                   \n" +
			"                  H             H                  \n" +
			"                 I               I                 \n" +
			"                J                 J                \n" +
			"               K                   K               \n" +
			"              L                     L              \n" +
			"             M                       M             \n" +
			"            N                         N            \n" +
			"           O                           O           \n" +
			"          P                             P          \n" +
			"         Q                               Q         \n" +
			"        R                                 R        \n" +
			"       S                                   S       \n" +
			"      T                                     T      \n" +
			"     U                                       U     \n" +
			"    V                                         V    \n" +
			"   W                                           W   \n" +
			"  X                                             X  \n" +
			" Y                                               Y \n" +
			"Z                                                 Z\n" +
			" Y                                               Y \n" +
			"  X                                             X  \n" +
			"   W                                           W   \n" +
			"    V                                         V    \n" +
			"     U                                       U     \n" +
			"      T                                     T      \n" +
			"       S                                   S       \n" +
			"        R                                 R        \n" +
			"         Q                               Q         \n" +
			"          P                             P          \n" +
			"           O                           O           \n" +
			"            N                         N            \n" +
			"             M                       M             \n" +
			"              L                     L              \n" +
			"               K                   K               \n" +
			"                J                 J                \n" +
			"                 I               I                 \n" +
			"                  H             H                  \n" +
			"                   G           G                   \n" +
			"                    F         F                    \n" +
			"                     E       E                     \n" +
			"                      D     D                      \n" +
			"                       C   C                       \n" +
			"                        B B                        \n" +
			"                         A                         ";

		// Act
		var result = DiamondBuilder.Build('Z');

		// Assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData('a')]
	[InlineData('1')]
	[InlineData('$')]
	public void Build_GivenInvalidInput_ThrowsArgumentException(char invalidInput)
	{
		// Act & Assert
		Assert.Throws<ArgumentException>(() => DiamondBuilder.Build(invalidInput));
	}
}
