class Controller {

  constructor(service) {
    this.service = service;
  }

  async getAll(queryParameters) {
    const data = await this.service.getAll(queryParameters);
    return data;
  }

  // async getByLocation(location) {
  //   const data = await this.service.getByLocation(location);
  //   return data;
  // }

  // async getByStatus(status) {
  //   const data = await this.service.getByStatus(status);
  //   return data;
  // }

  // async getByPriority(priority) {
  //   const data = await this.service.getByPriority(priority);
  //   return data;
  // }

  // async getAllVolunteers(){
  //   const data = await this.service.getAllVolunteers();
  //   return data;
  // }

  async get(id) {
    const data = await this.service.getById(id);
    return data;
  }

  async insert(newVolunteer) {
    const insertedObj = await this.service.insertNewVolunteer(newVolunteer);
    return insertedObj;
  }

  async update(helpRequestId, valunteerCode) {
    const updatedObj = await this.service.updateHelpRequest(helpRequestId, valunteerCode);
    return updatedObj
  }

  async delete(volunteerCode) {
    const response = await this.service.deleteVolunteer(volunteerCode);
    return response;
  }

}

module.exports = Controller;