using Controller;
using Model;
using Xunit;

namespace UnitTests.Movement
{
    public class RotateRightTests
    {
        [Theory]
        [InlineData(Position.CardinalDirection.NORTH, 1, 1)]
        public void MoveForward_WhenFacingNorth_ShouldRotateRight(Position.CardinalDirection direction, int x, int y)
        {
            // Arrange
            var position = new Position();
            position.Direction = direction;
            position.X = x;
            position.Y = y;

            // Act
            IMovementController movementController = new MovementController();
            var newPosition = movementController.RotateRight(position);

            // Assert
            if (newPosition.Y == y && newPosition.X == x && newPosition.Direction == Position.CardinalDirection.EAST)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }

        [Theory]
        [InlineData(Position.CardinalDirection.EAST, 1, 1)]
        public void MoveForward_WhenFacingEast_ShouldRotateSouth(Position.CardinalDirection direction, int x, int y)
        {
            // Arrange
            var position = new Position();
            position.Direction = direction;
            position.X = x;
            position.Y = y;

            // Act
            IMovementController movementController = new MovementController();
            var newPosition = movementController.RotateRight(position);

            // Assert
            if (newPosition.Y == y && newPosition.X == x && newPosition.Direction == Position.CardinalDirection.SOUTH)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }

        [Theory]
        [InlineData(Position.CardinalDirection.SOUTH, 1, 1)]
        public void MoveForward_WhenFacingSouth_ShouldRotateWest(Position.CardinalDirection direction, int x, int y)
        {
            // Arrange
            var position = new Position();
            position.Direction = direction;
            position.X = x;
            position.Y = y;

            // Act
            IMovementController movementController = new MovementController();
            var newPosition = movementController.RotateRight(position);

            // Assert
            if (newPosition.Y == y && newPosition.X == x && newPosition.Direction == Position.CardinalDirection.WEST)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }

        [Theory]
        [InlineData(Position.CardinalDirection.WEST, 1, 1)]
        public void MoveForward_WhenFacingWest_ShouldRotateNorth(Position.CardinalDirection direction, int x, int y)
        {
            // Arrange
            var position = new Position();
            position.Direction = direction;
            position.X = x;
            position.Y = y;

            // Act
            IMovementController movementController = new MovementController();
            var newPosition = movementController.RotateRight(position);

            // Assert
            if (newPosition.Y == y && newPosition.X == x && newPosition.Direction == Position.CardinalDirection.NORTH)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }
    }
}