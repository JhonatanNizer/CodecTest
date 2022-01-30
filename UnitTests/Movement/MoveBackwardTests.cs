using Controller;
using Model;
using Xunit;

namespace UnitTests.Movement
{
    public class MoveBackwardTests
    {
        [Theory]
        [InlineData(Position.CardinalDirection.NORTH, 1, 1)]
        public void MoveForward_WhenFacingNorth_ShouldMoveSouth(Position.CardinalDirection direction, int x, int y)
        {
            // Arrange
            var position = new Position();
            position.Direction = direction;
            position.X = x;
            position.Y = y;

            // Act
            IMovementController movementController = new MovementController();
            var newPosition = movementController.MoveBackward(position);

            // Assert
            if (newPosition.Y == --y && newPosition.X == x && newPosition.Direction == direction) 
            {
                Assert.True(true);
            } else 
            {
                Assert.True(false);
            }
        }

        [Theory]
        [InlineData(Position.CardinalDirection.EAST, 1, 1)]
        public void MoveForward_WhenFacingEast_ShouldMoveWest(Position.CardinalDirection direction, int x, int y)
        {
            // Arrange
            var position = new Position();
            position.Direction = direction;
            position.X = x;
            position.Y = y;

            // Act
            IMovementController movementController = new MovementController();
            var newPosition = movementController.MoveBackward(position);

            // Assert
            if (newPosition.Y == y && newPosition.X == --x && newPosition.Direction == direction)
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
        public void MoveForward_WhenFacingSouth_ShouldMoveNorth(Position.CardinalDirection direction, int x, int y)
        {
            // Arrange
            var position = new Position();
            position.Direction = direction;
            position.X = x;
            position.Y = y;

            // Act
            IMovementController movementController = new MovementController();
            var newPosition = movementController.MoveBackward(position);

            // Assert
            if (newPosition.Y == ++y && newPosition.X == x && newPosition.Direction == direction)
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
        public void MoveForward_WhenFacingWest_ShouldMoveEast(Position.CardinalDirection direction, int x, int y)
        {
            // Arrange
            var position = new Position();
            position.Direction = direction;
            position.X = x;
            position.Y = y;

            // Act
            IMovementController movementController = new MovementController();
            var newPosition = movementController.MoveBackward(position);

            // Assert
            if (newPosition.Y == y && newPosition.X == ++x && newPosition.Direction == direction)
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