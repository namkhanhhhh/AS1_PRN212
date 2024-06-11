using BusinessObjects;
using DataAccessLayer.DTO;
using Repositories;
using Repositories.Interface;
using Services.Interface;

namespace Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository iRoomRepository;

        public RoomService()
        {
            iRoomRepository = new RoomRepository();
        }

        public void AddRoom(RoomDTO room) => iRoomRepository.AddRoom(room);

        public void DeleteRoom(int roomId) => iRoomRepository.DeleteRoom(roomId);

        public List<RoomDTO> GetRooms(Func<RoomInformation, bool> predicate) => iRoomRepository.GetRooms(predicate);

        public void UpdateRoom(RoomDTO room) => iRoomRepository.UpdateRoom(room);

        public int CountRooms() => iRoomRepository.CountRooms();
    }
}
